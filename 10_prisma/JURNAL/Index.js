import { FPB, KPK, Turunan, Integral } from './Matematika.js';

console.log("FPB dari 60 dan 45: ", FPB(60, 45));
console.log("KPK dari 12 dan 8: ", KPK(12, 8));

const persamaan1 = [1, 4, -12, 9]; // x^3 + 4x^2 -12x + 9
console.log("Turunan dari x^3 + 4x^2 -12x + 9:");
console.log(Turunan(persamaan1));

const persamaan2 = [4, 6, -12, 9]; // 4x^3 + 6x^2 -12x + 9
console.log("Integral dari 4x^3 + 6x^2 -12x + 9:");
console.log(Integral(persamaan2));
