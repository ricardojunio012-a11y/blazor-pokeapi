# BlazorPokeApi

Aplicação **Blazor WebAssembly** (.NET 8) que busca um Pokémon pelo nome na [PokeAPI](https://pokeapi.co/) e mostra **imagem, ID, nome, altura e peso**.

Lista de Exercícios 23 — UC Usabilidade, Desenvolvimento Web, Mobile e Jogos — UNIBH.

## Como rodar

```bash
cd BlazorPokeApi
dotnet run
```

Abra o endereço mostrado no terminal, digite o nome do Pokémon (ex.: `pikachu`) e clique em **Buscar Pokémon**.

## Endpoint consumido

`GET https://pokeapi.co/api/v2/pokemon/{nome}`

- A imagem vem de `sprites.other["official-artwork"].front_default`.
- A API devolve altura em decímetros e peso em hectogramas; a tela converte para metros e quilos.

## Licença

MIT
