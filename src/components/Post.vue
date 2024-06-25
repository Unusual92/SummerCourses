<template>
    <router-link :to="{ name: 'postView', params: { id: this.post.id } }">
       
        <p >ID : {{ this.post.id }}</p>
        <h2 v-if="$route.path === '/'" >{{ truncate(this.post.title, 30) }}</h2>
        <h2 v-else >{{ this.post.title }}</h2>
        <p v-if="$route.path === '/'"  >{{truncate( this.post.body, 50) }}</p>
        <p v-else >{{this.post.body }}</p>
        
        

    </router-link>

</template>

<script>
export default {
    name: "postComponent",
    props: {
        post: {}
    },
    methods: {
    truncate(text, stop, clamp) {
        
      return text.slice(0, stop) + (stop < text.length ? clamp || '...' : '')
    }
}
}
</script>
