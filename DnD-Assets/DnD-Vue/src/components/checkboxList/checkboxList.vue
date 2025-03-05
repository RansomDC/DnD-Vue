<template>
    <ul :class="listType">
        <li v-for="checkbox in checkboxes">
            <ListCheckbox :model="checkbox"></ListCheckbox>
        </li>
    </ul>
</template>
  
<script setup lang="ts">
    import ListCheckbox from '../listCheckbox/listCheckbox.vue';
    import { ListCheckboxModel } from '../listCheckbox/listCheckboxModel';

    const props = defineProps({
        checkboxes: Array<ListCheckboxModel>,
        listType: String
    });
</script>

<style>
    ul {
        padding: 0;
    }
</style>