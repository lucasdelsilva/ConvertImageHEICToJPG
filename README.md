# Conversor HEIC para JPG

## Descrição
Utilitário em C# para converter imagens no formato HEIC (High Efficiency Image Format), usados por dispositivos iOS, para o formato JPG. O programa processa todas as imagens HEIC em uma pasta específica e as converte para JPG mantendo alta qualidade.

## Pré-requisitos

- .NET Framework/Core (versão recomendada: 6.0 ou superior)
- NuGet Package Manager
- Pacote Magick.NET-Q16-AnyCPU

### Instalação de Dependências

Via NuGet Package Manager Console:
```powershell
Install-Package Magick.NET-Q16-AnyCPU
```

## Funcionalidades

- Conversão em lote de arquivos HEIC para JPG
- Suporte para extensões em maiúsculo (.HEIC) e minúsculo (.heic)
- Preservação de qualidade de imagem (95%)
- Interface via console com feedback em tempo real
- Tratamento de erros robusto
- Criação automática da pasta de destino

## Como Usar

1. Execute o programa
2. Insira o caminho completo da pasta que contém as imagens HEIC
   2.1. C:\Users\{seuUsuario}\Downloads\{PastaComImagensHEIC}
4. Insira o caminho completo da pasta onde deseja salvar os arquivos JPG
   4.1 C:\Users\{seuUsuario}\Downloads\{PastaDestinoSalvarJPG}
6. Aguarde o processo de conversão

### Exemplo de Uso

```
Conversor de HEIC para JPG
==========================
Digite o caminho da pasta com as imagens HEIC: C:\Fotos\iPhone
Digite o caminho da pasta para salvar os JPGs: C:\Fotos\Convertidas

Encontrados 5 arquivos HEIC
Convertido: IMG_001.heic -> IMG_001.jpg
Convertido: IMG_002.heic -> IMG_002.jpg
Convertido: IMG_003.heic -> IMG_003.jpg
...
Conversão concluída!
```

## Estrutura do Código

O programa é estruturado em uma única classe que:
1. Valida os diretórios de entrada e saída
2. Identifica todos os arquivos HEIC no diretório
3. Converte cada arquivo usando ImageMagick
4. Fornece feedback em tempo real do progresso

## Tratamento de Erros

O programa inclui tratamento de erros para:
- Diretórios inexistentes
- Problemas de permissão
- Erros durante a conversão individual de arquivos
- Exceções gerais durante a execução

## Limitações

- Processa apenas arquivos com extensão .heic ou .HEIC
- Requer permissões de leitura na pasta de origem
- Requer permissões de escrita na pasta de destino
