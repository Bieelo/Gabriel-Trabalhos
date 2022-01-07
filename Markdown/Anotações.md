# **Introdução ao Git e ao GitHub**

- git init (iniciar o git)
- git add
- git commit
- ctrl + l (limpar tela)
- ls (listar pastas)
- ls -a (flag para mostrar arquivos ocultos)
//flag é tipo para acionar um comando alternativo
- cd .. (voltar um nível)
- git  status (verifica se nossa arvore de trabalho está limpa)
- mv  (mover itens)
// exemplo : mv (move) arquivo.txt ./pasta/


**Configuração do git**

- git config --global user.email "gabrielferreira15436@outlook.com"
- git config --global user.name Bieelo
- git remote add origin (adicionar origem remota)
//colocar no github
- git remote -v (lista repositorios remotos cadastrados)




**Reconfigurar**


- git config --global --unset user.email
- git confi --global --unset user.nickname


Adicionando arquivo Markdown na pasta livro-receitas
//HTML estrutura básica de qualquer pagina na web.
//Markdown é uma forma humanizada de se escrever HTML sem que você tenha que entender como o HTLM funciona de fato.

programa usado na criação do Markdown: Visual core studio



**Comandos do Windows** (CMD)

- cd (mudar pasta/diretorio)
- dir (listar itens da pasta)
- mkdir (criar pasta)
- del/rmdir (remover pasta)
- cls (limpar prompt de comando)

- unmodified: ao modificar o arquivo (Sha1 muda)
- modified: 
- staged: se preparando para fazer parte do commit

- untracked: o git não sabe nada a respeito do arquivo. Quer dizer, até sabe que ele existe, mas não vai controlar seu ciclo de vida
- staged: os que estão no staging area/index/cache. São os que estarão no próximo commit
- modified: os que foram alterados, se comparados ao último commit
- unmodified: os que não foram alterados

