<template lang="">
    <div>
        <button @click="IncrementValues">Увеличить значение</button>
        <table>
            <tr>
                <th v-for="num in numbers" :key="num">
                    {{num}}
                </th>
            </tr>
            <tr>
                <th v-for="num in numbers" :key="num">
                    {{num * InputNumber}}
                </th>
            </tr>
            <tr>
                <th v-for="num in numbers" :key="num">
                    {{(num * InputNumber)**2}}
                </th>
            </tr>
            <tr>
                <th v-for="num in numbers" :key="num">
                    {{num**2}}
                </th>
            </tr>


        </table>
        
    </div>
</template>
<script>


export default {
    name : "tableComponent",
    data(){
        return{
            numbers:[1,2,3,4,5,6,7,8,9,10]
        }
    },
    props:{
        InputNumber: Number
    }
    ,
    methods: {
        IncrementValues(){
           for(let i = 0; i < 10; i++){
                this.numbers[i]++;
           }
            }
        }
    }
    

</script>
<style scoped>
    th{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
    td{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
</style>