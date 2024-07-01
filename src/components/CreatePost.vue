<template>
    <div class="create-post-container">
      <input type="text" v-model="title" placeholder="Title" class="input-field"/>
      <input v-model="body" placeholder="Body" class="input-field" />
      <button @click="submitPost" class="submit-button">Создать</button>
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
  
  <style>
  .create-post-container {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 20px;
    padding: 20px;
    border: 1px solid #ddd;
    border-radius: 5px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
  }
  
  .input-field {
    width: 100%;
    padding: 10px;
    border: 1px solid #ddd;
    border-radius: 5px;
  }
  
  .submit-button {
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    background-color: #007bff;
    color: #fff;
    cursor: pointer;
    transition: background-color 0.3s;
  }
  
  .submit-button:hover {
    background-color: #0056b3;
  }
  </style>