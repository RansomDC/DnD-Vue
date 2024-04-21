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
      <div class="skeleton atr strength">
        <p class="label">STRENGTH</p>
        <input class="str" />
        <p class="str-mod mod"></p>
      </div>
      <div class="skeleton atr dexterity">
        <p class="label">DEXTERITY</p>
        <input class="dex" />
        <p class="dex-mod mod"></p>
      </div>
      <div class="skeleton atr constitution">
        <p class="label">CONSTITUTION</p>
        <input class="con" />
        <p class="con-mod mod"></p>
      </div>
      <div class="skeleton atr intelligence">
        <p class="label">INTELLIGENCE</p>
        <input class="int" />
        <p class="int-mod mod"></p>
      </div>
      <div class="skeleton atr wisdom">
        <p class="label">WISDOM</p>
        <input class="wis" />
        <p class="wis-mod mod"></p>
      </div>
      <div class="skeleton atr charisma">
        <p class="label">CHARISMA</p>
        <input class="cha" />
        <p class="cha-mod mod"></p>
      </div>
      <div class="skeleton inspiration">
        <input>
        <label></label>
      </div>
      <div class="skeleton proficiency">
        <input>
        <label></label>
      </div>
      <ul class="skeleton saving-throws">
        <li v-for="checkbox in attributesList">
          <ListCheckbox :model="checkbox"></ListCheckbox>
        </li>
      </ul>
      <ul class="skeleton skills">
        <li v-for="checkbox in skillsList">
          <ListCheckbox :model="checkbox"></ListCheckbox>
        </li>
      </ul>

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
      <div v-for="dropdown in traitList" class="skeleton" :class="dropdown">
        <traitDropdown :className="dropdown"></traitDropdown>
      </div>
    </div>
  </div>
</template>

<script setup lang=ts>
  import { ListCheckboxModel } from './listCheckbox/listCheckboxModel';
  import ListCheckbox from './listCheckbox/listCheckbox.vue';
  import { computed } from 'vue'
  import traitDropdown from './traitDropdown/traitDropdown.vue';
  import { onMounted } from 'vue';

  //temporary lists of different similar sectionss. Later I'll add ways to adjust these names and lists.
  const skillNames = ["Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival"]; 
  const attributeNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
  const traitNames = ["personality-traits", "ideals", "bonds", "flaws"];

  const attributesList = computed(() => {
    const attributes = new Array();
    attributeNames.forEach((skill) => {
      const attributeModel = new ListCheckboxModel("", skill);
      attributes.push(attributeModel);
    });
    return attributes;
  });

  const skillsList = computed(() => {
    const skills = new Array();
    skillNames.forEach((skill) => {
      const skillModel = new ListCheckboxModel("", skill);
      skills.push(skillModel);
    });
    return skills;
  });

  const traitList = computed(() => {
    const traits = new Array();
    traitNames.forEach((trait) => {
      traits.push(trait); 
    });
    return traits;
  });

  onMounted(() => {
    fetchtest();
  })

  function fetchtest() {
			fetch('http://localhost:5278/api/CharachterSheet/stuff-it')
				.then(response => {
					response.json().then(res => console.log(res));
				})
				.catch(err => {
					console.error(err);
				});
		}
</script>

<style>
  .display-grid {
    display: grid;
  }

  li {
    list-style: none;
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

      input {
        height: 2em;
        width: 2em;
      }
    }
    .proficiency {
      grid-row: 2;
      grid-column: 2 / 4;

      input {
        height: 2em;
        width: 2em;
      }
    }
    .saving-throws {
      grid-row: 3 / 7;
      grid-column: 2 / 4;
      grid-template-columns: 1fr 1fr 3fr;
    }
    .skills {
      grid-row: 7 / 14;
      grid-column: 2 / 4;
      grid-template-columns: 1fr 1fr 3fr;
    }
    .passive-perception {
      grid-row: 14;
      grid-column: 1 / 4;
    }
    .proficiencies-languages {
      grid-row: 15 / 19;
      grid-column: 1 / 4;
    }

    .atr {
      display: grid;
      justify-content: center;
      align-items: center;

      input {
        font-size: 16pt;
        height: 2em;
        width: 2em;
        font-weight: 600;
        margin: auto;
      }

      .mod {
        border: solid 1px red;
        width: 1em;
        height: 1em;
        margin: auto;
      }
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
      grid-row: 9 / 11;
      grid-column: 1 / 4;
    }
    .death-saves {
      grid-row: 9 / 11;
      grid-column: 4 / 7;
    }
    .attacks-spellcasting {
      grid-row: 11 / 14;
      grid-column: 1 / 7;
    }
    .equipment {
      grid-row: 14 / 19;
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

  .paragraph-style {
    border: 1px solid red;
    padding: 10px;
  }
</style>