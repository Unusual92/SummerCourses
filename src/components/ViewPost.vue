<template>
    <div class="view-post-container">
      <div v-for="post in this.posts.filter(p => p.id == this.id)" :key="post" class="post-container">
        <postComponent :post="post" :id="this.id"/>
      </div>
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
  
  <style>
  .view-post-container {
    display: flex;
    flex-direction: column;
    gap: 20px;
    padding: 20px;
  }
  
  .post-container {
    border: 1px solid #ddd;
    border-radius: 5px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    padding: 20px;
  }
  </style>