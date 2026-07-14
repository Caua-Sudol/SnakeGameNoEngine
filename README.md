# Snake Game (No Engine)

Jogo da cobrinha feito em C# rodando direto no terminal, sem nenhuma engine ou biblioteca gráfica. O objetivo foi focar exclusivamente na lógica do jogo (movimento, colisão, crescimento) sem nenhuma camada de abstração de engine no meio.

## Sobre o projeto

Toda a renderização acontece através do posicionamento do cursor no console (`Console.SetCursorPosition`), desenhando e apagando caracteres a cada frame. A cobra é representada por `#`, o rato por `*`, e o campo de jogo usa as dimensões atuais da janela do terminal.

Esse projeto foi o primeiro passo antes de uma versão com [MonoGame](https://github.com/Caua-Sudol/SnakeGameMonoGame), onde o mesmo problema foi resolvido de novo, dessa vez com sprites e assets reais.

Controles:

- `W`: mover para cima
- `A`: mover para esquerda
- `S`: mover para baixo
- `D`: mover para direita

Obs: no estado atual, pressionar qualquer tecla fora de WASD encerra o jogo, é o comportamento padrão do `InputHandler`.

## Estrutura

- `Program.cs`: loop principal do jogo.
- `Snake.cs`: corpo da cobra (fila de posições), movimento, colisão e crescimento.
- `Rat.cs`: posição do rato no grid.
- `InputHandler.cs`: leitura de teclado e bloqueio de reversão de direção (não deixa virar 180°).
- `Render.cs`: desenho e limpeza de caracteres no console.
- `Score.cs`: controle da pontuação.

## Como executar

```bash
dotnet restore
dotnet run
```

Recomendado rodar num terminal com espaço suficiente, o campo de jogo usa a largura e altura atuais da janela (`Console.WindowWidth` / `Console.WindowHeight`).
