<template>
  <div id="app">
    <router-view></router-view>
    <MovieContainer />
  </div>
</template>

<script>
import MovieContainer from './components/MovieContainer.vue'

export default {
  name: 'App',
  components: {
    MovieContainer
  },
  data() {
    return {
      
    }
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
