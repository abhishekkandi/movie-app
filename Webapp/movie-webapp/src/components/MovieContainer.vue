<template>
  <div>
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
            movies: []
        }
    },
    created() {
        this.getMovies()
    },
    methods: {
        getMovies(){
            fetch("https://localhost:44350/api/movies")
            .then(response => response.json())
            .then(data => (this.movies = data));
        }
    }
}
</script>

<style>

</style>