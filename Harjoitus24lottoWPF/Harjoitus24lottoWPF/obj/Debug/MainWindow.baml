   M S B A M L   `   `   `  ����N  JHarjoitus24lottoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Harjoitus24lottoWPFHarjoitus24lottoWPF  5   	   $    Harjoitus24lottoWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Harjoitus24lottoWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Monta riviä:��6!   $��Center=�65   �� 5   
   -   5         ��Name$ txtMontaRivia��5      $��0��6)   $��1��66   $��Center=�6F   �� 5   
   $��1��6   $��Pelivalinta:��6!   $��Center=�65   �� 5   
   -   5         ��Name$ cmbPelivalinta��5      $��1��6+   $��1��68   $��Center=�6H   .@�5      �� $��Lotto��6   �� 5      $��Viking Lotto��6   �� 5      $��Eurojackpot��6   5      �� 5   
   -   5        $��2��5      $��Tulosta��6   60   �� 5   
   -   5        $��3��5      $��	Tyhjennä��6   61   �� 5   
   -   5        $��4��5      $��Viikon Arvonta��6   67   �� 5!   
   $��5��6   $
��Auto=�6$   .��5"      �� -   5         ��Name$ txtArvotutRivit��5"      5#      5$      5%      