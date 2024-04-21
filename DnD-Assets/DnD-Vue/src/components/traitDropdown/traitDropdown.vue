<template>
  <select></select>
  <label>{{ props.className }}</label>
</template>

<script setup lang="ts">
  const props = defineProps({
    className: String
  });
</script>

<style>

</style>