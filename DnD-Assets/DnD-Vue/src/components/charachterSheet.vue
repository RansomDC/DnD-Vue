<template>
  <div class="char-header display-grid">
    <div class="char-name">
      <input>
      <label>Charachter Name</label>
    </div>
    <div class="display-grid char-details">
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
      <div class="char-alignment">
        <input>
        <label>Alignment</label>
      </div>
      <div class="char-experience-points">
        <input>
        <label>Experience Points</label>
      </div>
    </div>
  </div>

  <div class="char-body skeleton display-grid">
    <div class="skeleton body-left">
      <div class="skeleton atr strength"></div>
      <div class="skeleton atr dexterity"></div>
      <div class="skeleton atr constitution"></div>
      <div class="skeleton atr intelligence"></div>
      <div class="skeleton atr wisdom"></div>
      <div class="skeleton atr charisma"></div>
      <div class="skeleton inspiration"></div>
      <div class="skeleton proficiency"></div>
      <div class="skeleton saving-throws"></div>
      <div class="skeleton skills"></div>
      <div class="skeleton passive-perception"></div>
      <div class="skeleton proficiencies-languages"></div>
    </div>
    <div class="skeleton body-center">
      <div class="skeleton armor-class"></div>
      <div class="skeleton initiative-bonus"></div>
      <div class="skeleton speed"></div>
      <div class="skeleton hp"></div>
      <div class="skeleton temp-hp"></div>
      <div class="skeleton hit-dice"></div>
      <div class="skeleton death-saves"></div>
      <div class="skeleton attacks-spellcasting"></div>
      <div class="skeleton equipment"></div>
    </div>
    <div class="skeleton body-right">
      <div class="skeleton personality-traits"></div>
      <div class="skeleton ideals"></div>
      <div class="skeleton bonds"></div>
      <div class="skeleton flaws"></div>
      <div class="skeleton features-traits"></div>
    </div>
  </div>
</template>

<script setup lang=ts>

</script>

<style>
  .display-grid {
    display: grid;
  }

  .char-header {
    grid-template-columns: 20% auto;
  }

  .char-details {
    grid-template-columns: repeat(4, 1fr);;
  }

  .char-header input {
    display: block;
  }

  .char-body {
    grid-template-columns: repeat(3, 1fr);
    gap: 15px;
  }

  .body-left {
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    grid-template-rows: repeat(18, 1fr);
    gap: 5px;

    .strength {
      grid-row: 2 / 4;
      grid-column: 1;
    }
    .dexterity {
      grid-row: 4 / 6;
      grid-column: 1;
    }
    .constitution {
      grid-row: 6 / 8;
      grid-column: 1;
    }
    .intelligence {
      grid-row: 8 / 10;
      grid-column: 1;
    }
    .wisdom {
      grid-row: 10 / 12;
      grid-column: 1;
    }
    .charisma {
      grid-row: 12 / 14;
      grid-column: 1;
    }

    .inspiration {
      grid-row: 1;
      grid-column: 2 / 4;
    }
    .proficiency {
      grid-row: 2;
      grid-column: 2 / 4;
    }
    .saving-throws {
      grid-row: 3 / 7;
      grid-column: 2 / 4;
    }
    .skills {
      grid-row: 7 / 14;
      grid-column: 2 / 4;
    }
    .passive-perception {
      grid-row: 14;
      grid-column: 1 / 4;
    }
    .proficiencies-languages {
      grid-row: 15 / 19;
      grid-column: 1 / 4;
    }
  }

  .body-center {
    display: grid;
    grid-template-columns: repeat(6, 1fr);
    grid-template-rows: repeat(18, 1fr);
    gap: 5px;

    .armor-class {
      grid-row: 1 / 3;
      grid-column: 1 / 3;
    }
    .initiative-bonus {
      grid-row: 1 / 3;
      grid-column: 3 / 5;
    }
    .speed {
      grid-row: 1 / 3;
      grid-column: 5 / 7;
    }
    .hp {
      grid-row: 3 / 6;
      grid-column: 1 / 7;
    }
    .temp-hp {
      grid-row: 6 / 9;
      grid-column: 1 / 7;
    }
    .hit-dice {
      grid-row: 9 / 12;
      grid-column: 1 / 4;
    }
    .death-saves {
      grid-row: 9 / 12;
      grid-column: 4 / 7;
    }
    .attacks-spellcasting {
      grid-row: 12 / 15;
      grid-column: 1 / 7;
    }
    .equipment {
      grid-row: 15 / 19;
      grid-column: 1 / 7;
    }
  }

  .body-right {
    display: grid;
    grid-template-rows: repeat(18, 1fr);
    gap: 5px;

    .personality-traits {
      grid-row: 1 / 3;
    }
    .ideals {
      grid-row: 3 / 5;
    }
    .bonds {
      grid-row: 5 / 7;
    }
    .flaws {
      grid-row: 7 / 9;
    }
    .features-traits {
      grid-row: 9 / 19;
    }
  }

  .skeleton {
    padding:10px;
    border: 1px solid violet;
  }
</style>