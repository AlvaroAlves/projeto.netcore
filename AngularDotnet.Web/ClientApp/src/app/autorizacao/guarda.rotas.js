"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.GuardaRotas = void 0;
var GuardaRotas = /** @class */ (function () {
    function GuardaRotas() {
    }
    GuardaRotas.prototype.canActivate = function (route, state) {
        //se usuario estiver autenticado retorna verdadeiro
        //fixo por enquanto
        return true;
    };
    return GuardaRotas;
}());
exports.GuardaRotas = GuardaRotas;
//# sourceMappingURL=guarda.rotas.js.map