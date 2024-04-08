let e = {
  buttonsLT: document.getElementById("#buttonsLT"),
  fight_difficultyLT: document.getElementById("#fight_difficultyLT"),
  dungeon_lootLT: document.getElementById("#dungeon_lootLT"),
  fight_difficultyBT: document.getElementById("#encounter_diffBT"),
  dungeon_lootBT: document.getElementById("#dungeon_lootBT"),
};

let server = "http://localhost:5109";

e.fight_difficultyBT.onclick = () => {
  e.fight_difficultyLT.style.visibility = "visible";
};

e.dungeon_lootBT.onclick = () => {
  e.dungeon_lootLT.style.visibility = "visible";
}
