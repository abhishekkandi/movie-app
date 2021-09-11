<template>
  <ul id="movie-list">
      <li v-for="movie in movies" :key="movie.imdbid">
          <a @click="redirectToMovieDetailPage(movie)">{{movie.title}}</a>
      </li>
  </ul>
</template>

<script>
export default {
    name: "MovieList",
    props: {
        movies : []
    },
    methods: {
        redirectToMovieDetailPage(movie){
            console.log(movie)
            this.$router.push({name: 'movie', params: { movieid: movie.imdbid }}).catch(()=>{});
        }
    }
}
</script>

<style>

</style>