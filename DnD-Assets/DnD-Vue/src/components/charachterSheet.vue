<template>
  <div class="char-header">
    <div class="char-name display-inline">
      <input>
      <label>Charachter Name</label>
    </div>
    <div class="display-inline">
      <div class="char-class">
        <input>
        <label>Class</label>
      </div>
      <div class="char-level">
        <input>
        <label>Level</label>
      </div>
      <div class="char-background">
        <input>
        <label>Background</label>
      </div>
      <div class="char-player-name">
        <input>
        <label>Player Name</label>
      </div>
      <div class="char-race">
        <input>
        <label>Race</label>
      </div>
      <div class="char-Alignment">
        <input>
        <label>Alignment</label>
      </div>
      <div class="char-Alignment">
        <input>
        <label>Experience Points</label>
      </div>
    </div>
  </div>
</template>

<script setup lang=ts>

</script>

<style>
  .display-grid {
    display: grid;
  }

  .display-inline {
    display: inline;
  }

  .char-header input {
    display: block;
  }
</style>