import Vue from 'vue'
import VueRouter from "vue-router";

Vue.use(VueRouter);

import MovieContainer from './components/MovieContainer.vue'
import MovieDetails from './components/MovieDetails.vue'

const routes = [
    {
        path: "/",
        name: "movies",
        component: MovieContainer
    },
    {
        path: "/movie/:movieid",
        name: "movie",
        component: MovieDetails
    }
]

const router = new VueRouter({
    linkActiveClass: 'active',
    base: '/',
    mode: 'history',
    routes 
})

export default router;