import { createRouter, createWebHistory } from "vue-router";
import homeComponent from "@/components/Home.vue"
import createPostComponent from "@/components/CreatePost.vue"
import viewPostComponent from "@/components/ViewPost.vue"

const routes = [
    {
        "path": "/",
        "component": homeComponent,
        "props": true
    },
    {
        "path": "/post/create",
        "component": createPostComponent
    },
    {
        "path": "/post/:id",
        "component": viewPostComponent,
        "name": "postView",
        "props": true
    }
]

const router = createRouter({
    routes,
    history : createWebHistory()
})

export default router;