<template>
   <router-link to="/">Главная</router-link> <br>
   <router-link to="/post/create">Создать</router-link>
  <router-view @post-create="NewPostCreated" :posts="posts" :id="$route.params.id"/>
</template>

<script>


import axios from "axios";

export default {
  name: 'App',

  data() {
    return {
      posts: []
    }
  },

  methods: {
    NewPostCreated(data) {
      this.posts = this.posts.reverse();
      this.posts.push({
        "user_id": this.posts.at(0).user_id,
        "id": this.posts.at(-1).id + 1,
        "title": data.title,
        "body": data.body
      });
      this.posts = this.posts.reverse();
    }
  },
  async created() {
    const response = await axios.get("https://jsonplaceholder.typicode.com/posts");
    this.posts = response.data.reverse();
  }
}

</script>
