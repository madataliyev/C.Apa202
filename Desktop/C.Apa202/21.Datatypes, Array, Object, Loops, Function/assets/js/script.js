// 1
// function tekrarlariSil(massiv){
//     let yeniMassiv=[];
//     let silinenlerinSayi=0;

//     for (let i = 0; i < massiv.length; i++) {
//         let movcud = false;
//         for (let j = 0; j < yeniMassiv.length; j++) {
//            if (massiv[i]===yeniMassiv[j]) {
//             movcud=true
//             break;
//            }
         
//         }
//         if (movcud=== false) {
//             yeniMassiv.push(massiv[i]);
//         }
//         else{
//             silinenlerinSayi++;
//         }

//     }
//     console.log('temizlenmis siyahi :', yeniMassiv);
//     console.log('silinen reqemlerin sayi:',silinenlerinSayi);

// }
// let testMassiv=[10,20,10,30,40,20,50,10]
// tekrarlariSil(testMassiv)

// 2
// function polindromYoxla(soz){
//     let tersSoz='';

//     for (let i = soz.length-1; i >=0; i--) {
//         tersSoz=tersSoz+soz[i];
  
//     }
//     if (soz===tersSoz) {
//         console.log(soz+'-> Polindrom');
        
//     }
//     else{
//         console.log(soz +'-> Polindrom deyil');
        
//     }
// }
// let test='ala';
// let test1='salam';
// polindromYoxla(test);
// polindromYoxla(test1);

// 3
// function kicikSay(daxilEdilenEded,massiv) {
//     let saygac=0;

//     for (let i = 0; i < massiv.length; i++) {
//         if (daxilEdilenEded<massiv[i]) {
//             saygac++;
//         }
        
//     }
//     console.log('dexil edilen eded : '+ daxilEdilenEded);
//     console.log('massivde ededden boyuk olan reqemlerin sayi :'+saygac);
  
// }
// let massiv=[5,12,8,20,3,15];
// let eded=10;
// kicikSay(eded,massiv);

// 4
// function edediYoxla(eded) {
//     let bolenlerinCemi=0;

//     for (let i = 0; i< eded ; i++) {
//         if (eded%i===0) {
//             bolenlerinCemi=bolenlerinCemi+i;
//         }
//     }
//     if (bolenlerinCemi> eded) {
//         console.log(eded +'Abundant ededdir (bolenlerin cemi:'+bolenlerinCemi+')');
//     }
//     else{
//           console.log(eded +'Deficient  ededdir (bolenlerin cemi:'+bolenlerinCemi+')');
//     }
// }
// let test =12;
// let test1=13;
// edediYoxla(test)
// edediYoxla(test1)

// 5
// function kvadratlarYukselt(massiv) {
//     let kvadratlarMassivi=[];

//     for (let i = 0; i < massiv.length; i++) {
//         let kvadrat= massiv[i]*massiv[i];

//         kvadratlarMassivi.push(kvadrat)
   
//     }
//     return kvadratlarMassivi;
// }
// let massiv=[2,4,5,10];
// let netice=kvadratlarYukselt(massiv)
// console.log('Orijinal massiv:', massiv);
// console.log('Kvadratlar massivi:', netice);
