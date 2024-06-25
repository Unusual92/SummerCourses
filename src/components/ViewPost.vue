<template>
    <div v-for="post in this.posts.filter(p => p.id == this.id)" :key="post">
      <postComponent :post="post" :id="this.id"/>
    </div>
  </template>
  
  <script>
  import postComponent from "@/components/Post.vue"
  
  export default {
      name: "viewPost",
      components: {
          postComponent
      },
      props: {
          id: Number,
          posts: []
      },
      data() {
          return {
              post: {}
          }
      }
  }
  </script>
  
