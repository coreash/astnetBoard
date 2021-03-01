﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('.editor').trumbowyg({
    lang: 'ko',
    btnsDef: {
        image: {
            dropdown: ['insertImage', 'upload'],
            ico: 'insertImage'
        },
    },
    btns: [
        ['viewHTML'],
        ['formatting'],
        'btnGrp-semantic',
        ['superscript','subscript'],
        ['link'],
        ['insertImage'],
        'image',
        'btnGrp-justify',
        'btnGrp-lists',
        ['horizontalRule'],
        ['removeFormat'],
        ['fullscreen'],
    ]
});