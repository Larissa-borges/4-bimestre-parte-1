.cabeçalho__menu-hamburguer {
    width: 24px;
    height: 24px;
    display: inline-block;
    background-image: url("../img/Menu.svg");
    background-repeat: no-repeat;
    background-position: center;
}

.cabeçalho {
    background-color: var(--branco);
    display: flex;
    justify-content: space-between;
    align-items: center;
    position: relative;
}

.container {
    display: flex;
    align-items: center;
}

.container__imagem {
    padding: 1em;
}

.lista-menu {
    display: none;
    position: absolute;
    top: 100%;
    width: 60vw;
}

.container__botao:checked ~ .lista-menu {
    display: block;
}

.lista-menu__titulo,
.lista-menu__item {
    padding: 1em;
    background-color: var(--branco);
}

.lista-menu__titulo {
    color: var(--laranja);
    font-weight: 700;
}

.lista-menu__link {
    background: var(--azul-degrade);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
    text-transform: uppercase;
}

.container__botao {
    display: none;
}