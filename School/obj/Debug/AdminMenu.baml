   M S B A M L   `   `   `  ????A  =School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SchoolSchool  5   	       School.AdminMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:School     5   	     ? Title$  	AdminMenu??5   	   $	??450??6   $	??800??6(    ? WindowStartupLocation$ CenterScreen=?64   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 test??5
   j   $??0,0,0,60q?6<      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Ученик??67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   ?? *Student.FullName+6n   4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        yan??$ Январь??5   6      SelectedValueBinding 6F   ?? *Yan_e+6o     5      -   5        fev??$ Февраль??5   6    6G   ?? *Fev_e+6p     5      -   5        mar??$ Март??5   6    6D   ?? *Mar_e+6m     5      -   5        apr??$ Апрель??5   6    6F   ?? *Apr_e+6o     5      -   5        may??$ Май??5   6    6C   ?? *May_e+6l     5      -   5        iun??$ Июнь??5   6    6D   ?? *Iun_e+6m     5      -   5        iul??$ Июль??5   6    6D   ?? *Iul_e+6m     5      -	   5        avg??$ Август??5   6    6F   ?? *Avg_e+6o     5      -
   5        sen??$ Сентябрь??5   6    6H   ?? *Sen_e+6q     5      -   5        oct??$ Октябрь??5   6    6G   ?? *Oct_e+6p     5      -   5        	noyab??$ Ноябрь??5   8    6H   ?? *	Noyab_e+6s     5      -   5        dec??$ Декабрь??5   6    6G   ?? *Dec_e+6p     5       . $ Средняя??67    6H   ?? *SrE+6b   5      ?? 5   
   $??Center=?6   	 ?? Orientation$	 
Horizontal=?62   .+?5      ?? -   5        
 ??Name$
 SaveB??5   C   $??0,0,0,5q?6   $??Center=?6&   $??Bottom=?6R   .??6?   Сохранить6?   ?? 5      -   5        $

 addU??5   C   $??5,0,0,5q?6   $??Center=?6&   $??Bottom=?6Q   .??6   !Добавить ученика6?   5      ?? 5    
   -   5        $

 exit??5    =   $??5,0,0,5q?6   $
??Left=?6"   $??Bottom=?6K   .??6y   
Выход6?   5!      5"      