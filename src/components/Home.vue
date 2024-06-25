<template>
    <div v-for="post in this.posts" :key="post">
      <postComponent :post="post"/>
    </div>
  </template>
  
  <script>
  
  import postComponent from '@/components/Post.vue';
  
  export default {
      name: "homeComponent",
      components: {
          postComponent
      },
      props: {
          posts: []
      }
  }
  
  </script>
