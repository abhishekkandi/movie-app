<template>  
  <div class="movie-details">
      <h1>{{movieData.title}}</h1>
      <p>{{movieData.plot}}</p>    
      <div>
          <img :src="getPoster(movieData)" alt="poster"/>
      </div>
      <div>
          <span>Language - {{movieData.language}},</span>      
          <span> Location - {{movieData.location}}</span>    
      </div>
      <div>
          <span>Sound Effects - {{movieData.soundEffects.join(',')}}</span>          
      </div> 
      <div> 
        <span>IMDB Rating - {{movieData.imdbRating}}</span>
      </div>
      <div>
          <span>Listing type - {{cListingType}}</span>
      </div>
      <button class="button" v-on:click="redirectToMainPage()">Go back to Movie list</button>
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
    created() {
        this.getMovieDetails()
    },
    computed: {
        cListingType(){
            if(this.movieData.listingType){
                return this.movieData.listingType.replace('_',' ')
            }
        }
    },
    methods: {
        getMovieDetails(){
            console.log(this.$route.params.movieid)
            fetch(`https://localhost:44350/api/movie/${this.$route.params.movieid}`)
            .then(response => response.json())
            .then(data => (this.movieData = data));            
        },
        getPoster(movie){
            return movie.poster;
        },
        redirectToMainPage(){
            this.$router.push({name: 'movies'})
        }
    }
}
</script>

<style>
div{
    padding: 1rem;
}
.movie-details {
    border-style: outset;

}
.button {
  background-color: grey; /* Green */
  border: none;
  color: white;
  padding: 15px 32px;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
}
</style>