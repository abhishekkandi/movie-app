<template>
  <div>
      <h1>{{movieData.title}}</h1>
      <p>{{movieData.plot}}</p>      
  </div>
</template>

<script>
export default {
    props: {
        
    },
    data(){
        return {
            movieData: {}
        }
    },
    methods: {
        getMovieDetails(id){
            console.log(id)
            this.movieData = {
                title : 'The Dark Knight',
                plot:`Voldemort's power is growing stronger. He now has control over the Ministry of Magic and Hogwarts.`,                
            }
        }
    }
}
</script>

<style>

</style>