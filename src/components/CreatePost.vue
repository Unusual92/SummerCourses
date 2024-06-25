<template>
    <div>
      <input type="text" v-model="title" placeholder="Title"/>
      <input v-model="body" placeholder="Body" />
      <button @click="submitPost">Создать</button>
    </div>
  </template>
  
  <script>
  export default {
      name: "createPost",
      data() {
          return {
              title : "",
              body : ""
          }
      },
      methods : {
          submitPost() {
              this.$emit('post-create', {
                  "title": this.title,
                  "body": this.body
              });
              this.$router.push("/");
          }
      }
  }
  </script>
  
