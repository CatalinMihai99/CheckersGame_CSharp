   M S B A M L   `   `   `  ����H  Dcheckers_game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:checkers_game.Viewcheckers_game.View  5   	   %    checkers_game.View.Instructions   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:checkers_game.View     5   	     � Title$  Instructions��5   	   $	��450��6   $	��800��6+   ��5	      �� 5
   
    �� ImageSource$3 -/checkers_game;component/Resources/fundal.jpg��6   6S   .��5      � .+�5   
   �� $��Jocul de Dame��6   $
��Bold"�6(   $��30(�6:   $��
JasmineUPC)�6H   $��Oblique$�6`   $
��Left=�6t   $��523,26,-39,0q�6�   $	��Top=�6�   $	��308��6�   $��57��6�    J� RenderTransformOrigin$ 1.098,2.683&�6�   �� 5   
   $
��Bold"�6   $����Poziţia de început pentru jocul de dame este cea prezentată în Figura 1.
Jucatorul cu piesele rosii va fi primul care muta, dupa care vor efectua pe rand, cate
o mutare, fiecare dintre jucatori. Aplicatia trebuie sa marcheze vizual jucatorul care este la
mutare.
Mutarea – exista mai multe tipuri de mutări:
• Mutarea simpla – piesa se deplaseaza o casuta, pe diagonala, in fata. Daca piesa
a reusit sa ajunga la capatul opus al tablei de joc, atunci se va transforma in rege şi mutarea sa va fi tot cu o casuta, pe diagonala, dar se va putea deplasa
atat in fata cat si in spate. Piesele schimbate in rege vor avea aceeasi culoare ca
restul pieselor jucatorului, dar o imagine diferita.
• Saritura peste adversar – atunci cand o piesa are o piesa adversa pe una dintre
pozitiile sale de mutare, atunci acea piesa va sari peste cea adversa, facand-o sa
dispara de pe tabla de joc. Un jucător poate sari doar peste piesele adversarului
pentru a le captura, nu si peste piese de ale sale.
• Sarituri multiple – daca un jucator a sarit peste o piesa adversa si in imediata
vecinatate a sa se gaseste inca o piesa adversa care poate fi capturata, va face
inca o saritura, si tot asa pana cand nu va mai putea captura piese adverse.
Jucatorii vor putea efectua aceste sarituri doar daca se opteaza inca de la
inceputul jocului pentru efectuarea de sarituri multiple.
Finalul jocului – jocul se incheie in momentul in care unul dintre jucatori nu mai are
piese pe tabla de joc. Jucatorul advers va fi in acest caz castigatorul��6"   $
��Left=�6�  $��	10,26,0,0q�6�  $	��Top=�6�  $	��491��6  $	��337��6  �� 5   
   $2��,/checkers_game;component/Resources/tabla.jpg��6   $��523,65,46,29q�6F   �� 5   
   -   5        $��Despre dezvoltator��5      $
��Left=�6.   $��523,370,0,0q�6I   $	��Top=�6^   $	��117��6v   6�   �� 5   
   -   5        $
��Back��5      $
��Left=�6    $��371,370,0,0q�6;   $	��Top=�6P   $��75��6h   6s   5      5      