


    function hesapla(){
      console.log("****")
         sayi1=document.getElementById("height").value;
         sayi2=document.getElementById("neck").value;
         sayi3=document.getElementById("bel").value;
         sayi4=document.getElementById("kalca").value;
       console.log(sayi1,sayi2,sayi3,sayi4);

       if(document.getElementById("male").checked){

        document.getElementById("sonuc").innerHTML = (495/((1.0324) - (0.19077*Math.log10(sayi3-sayi2) )+ (0.15456*Math.log10(sayi1))))-450;
    }

      else if(document.getElementById("female").checked){

        document.getElementById("sonuc").innerHTML = (495/((1.29579) - (0.35004*Math.log10(sayi4+sayi3-sayi2) )+ (0.22100*Math.log10(sayi1))))-450;
    }





}

function kalorihesapla(){

    console.log("****");
    

     sayi1=document.getElementById("weight").value;
     sayi2=document.getElementById("yag").value;
     
   console.log(sayi1,sayi2);





}

    
        
  