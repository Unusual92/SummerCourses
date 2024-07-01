<template>
  <div class="app-container">
    <nav class="nav-links">
      <router-link to="/" class="nav-link">Главная</router-link>
      <router-link to="/post/create" class="nav-link">Создать</router-link>
    </nav>
    <router-view @post-delete="postDelete" :key="$route.fullPath" @post-create="NewPostCreated" :posts="posts" :id="$route.params.id" />
  </div>
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
    },
    postDelete(index) {
      this.posts.splice(index - 1, 1);
      alert("Post deleted");
    }
  },
  async created() {
    const response = await axios.get("https://jsonplaceholder.typicode.com/posts");
    this.posts = response.data.reverse();
  }
}
</script>

<style>
.app-container {
  font-family: Arial, sans-serif;
  padding: 20px;
}

.nav-links {
  display: flex;
  justify-content: space-around;
  margin-bottom: 20px;
}

.nav-link {
  text-decoration: none;
  color: #333;
  padding: 10px;
  border: 1px solid #ddd;
  border-radius: 5px;
  transition: background-color 0.3s;
}

.nav-link:hover {
  background-color: #f0f0f0;
}
</style>
