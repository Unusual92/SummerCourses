<template>
    <div class="post-link" >
    <router-link :to="{ name: 'postView', params: { id: this.post.id } }" class="post-link">
      <p class="post-id">ID : {{ this.post.id }}</p>
      <h2 class="post-title">{{ $route.path === '/' ? truncate(this.post.title, 30) : this.post.title }}</h2>
      <p class="post-body">{{ $route.path === '/' ? truncate(this.post.body, 50) : this.post.body }}</p>
    </router-link>
      <button @click="deletePost" >удалить</button>
    </div>
  </template>

<script>
export default {
    name: "postComponent",
    props: {
        post: {},
        id:Number
    },
    methods: {
    truncate(text, stop, clamp) {
        
      return text.slice(0, stop) + (stop < text.length ? clamp || '...' : '')
    },
    deletePost(){
        this.$emit('postDelete',
                  this.id)
              this.$router.push("/");
              
    }
}
}
</script>

<style>
.post-link {
  text-decoration: none;
  color: #333;
  padding: 20px;
  border: 1px solid #ddd;
  border-radius: 5px;
  transition: background-color 0.3s;
  display: flex;
  flex-direction: column;
  gap: 10px;
}

.post-link:hover {
  background-color: #f0f0f0;
}

.post-id {
  font-size: 0.8em;
  color: #777;
}

.post-title {
  margin: 0;
}

.post-body {
  color: #555;
}
.post-link button {
  background-color: #ff6347;
  color: white;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  transition: background-color 0.3s;
  align-self: flex-end;
}

.post-link button:hover {
  background-color: #ff4500;
}
</style>