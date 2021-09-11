<template>
  <div class="movie-container">
      <div class="spread">
        <h1>Box Office</h1>
        <div>
            <button v-if='!cShowSearchBox' @click="showSearchBoxButton()">Show Search Box</button>
            <div v-if="cShowSearchBox">
                <input v-model="titleSearchText" placeholder="search by title" />
                <button @click="searchByTitle()">Search</button>
                <button @click="hideSearchBoxButton()">Hide</button>
            </div>
        </div>
        <div>
            <button v-if="!cShowFilters" @click="showFiltersButton()">Show Filters</button>
            <div v-if="cShowFilters">
                <span>Language: </span>
                <select v-model="selectedLanguage">
                    <option></option>
                    <option>hindi</option>
                    <option>english</option>
                </select>
                <span> Location: </span>
                <select v-model="selectedLocation">
                    <option></option>
                    <option>pune</option>
                    <option>delhi</option>
                    <option>bangalore</option>
                </select>
                <button @click="applyFilter()">Apply</button>
                <button @click="clearFilter()">Clear</button>
                <button @click="hideFiltersButton()">Hide</button>
            </div>
        </div>
      </div>
      <MovieList :movies="movies"/>
  </div>
</template>

<script>

import MovieList from './MovieList.vue'

export default {
    name: "MovieContainer",
    components:{
        MovieList
    },
    props: {
        
    },
    data(){
        return {
            movies: [],
            titleSearchText: '',
            selectedLanguage:'',
            selectedLocation: '',
            showSearchBox: false,
            showFilters: false
        }
    },
    created() {
        this.getMovies()        
    },
    computed : {
        cShowSearchBox() {
            return this.showSearchBox
        },
        cShowFilters(){
            return this.showFilters
        }
    },
    methods: {
        getMovies(){
            fetch("https://localhost:44350/api/movies")
            .then(response => response.json())
            .then(data => (this.movies = data));
        },
        searchByTitle(){
            fetch(`https://localhost:44350/api/movies?title=${this.titleSearchText}`)
            .then(response => response.json())
            .then(data => (this.movies = data));
        },
        applyFilter(){        
            fetch(`https://localhost:44350/api/movies?language=${this.selectedLanguage}&location=${this.selectedLocation}`)
            .then(response => response.json())
            .then(data => (this.movies = data));
        },
        clearFilter(){
            this.selectedLocation = ''
            this.selectedLanguage = ''
            this.getMovies()
        },
        showSearchBoxButton(){
            this.showSearchBox = true;
        },
        hideSearchBoxButton(){
            this.showSearchBox = false;
        },
        showFiltersButton(){
            this.showFilters = true;
        },
        hideFiltersButton(){
            this.showFilters = false;
        }
    }
}
</script>

<style>
.movie-container{
    border-style: outset;
}
.spread {
    display: flex;
    justify-content: center;
    align-items: center;
    align-content: space-between;
}
</style>