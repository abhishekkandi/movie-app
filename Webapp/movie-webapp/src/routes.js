import Vue from 'vue'
import VueRouter from "vue-router";

Vue.use(VueRouter);

import MovieDetailPage from './components/MovieDetails.vue'

const router = new VueRouter({
    linkActiveClass: 'active',
    base: '/',
    mode: 'history',
    routes 
})

const routes = [
    {
        path: "/movie/:movieid",
        name: "movie",
        component: MovieDetailPage
    }
]

export default router;