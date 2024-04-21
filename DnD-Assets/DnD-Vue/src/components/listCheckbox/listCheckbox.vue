<template>
  <label class="skill-checkbox display-grid">
    <input type="checkbox">
    <p class="paragraph-style"></p>
    {{props.model?.Label}}
  </label>
</template>

<script setup lang="ts">
  import { ListCheckboxModel } from './listCheckboxModel';

  const props = defineProps({
    model: ListCheckboxModel
  });
</script>

<style>
  .skill-checkbox {
    grid-template-columns: 1fr 1fr 4fr;
  }
</style>