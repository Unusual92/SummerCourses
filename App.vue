<template>
  <input type = "number" v-model="number"/>
  <tableComponent :InputNumber="number"/>
</template>

<script>
import tableComponent from "@/components/table";

export default {
  name: 'App',
  components:{
    tableComponent
  }
  ,
  data(){
    return{
      number: 0,
    }
  }
  }

</script>

