   M S B A M L   `   `   `  ����V  RRestAPIWPFVanDesktopSum2023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:RestAPIWPFVanDesktopSum2023RestAPIWPFVanDesktopSum2023  5   	   ,    &RestAPIWPFVanDesktopSum2023.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:RestAPIWPFVanDesktopSum2023     5   	     � Title$  RestAPI Testing��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ studentList��5
      $��137,258,130,49q�6)   �� 5   
   -   5         ��Name$
 Name��5      $
��Left=�6    $��
210,94,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $	��Top=�6c   $	��162��6{   $��14(�6�   �� 5   
   -   5         ��Name$ namelb��5      $
��Name��6    $
��Left=�6/   $��
135,91,0,0q�6J   $	��Top=�6^   $��14(�6v   �� 5   
   -   5        $ Id��5      $
��Left=�6   $��210,132,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��162��6z   $��14(�6�   �� 5   
   -   5        $ idLbl��5      $��ID��6   $
��Left=�6,   $��141,127,0,0q�6G   $	��Top=�6\   $��14(�6t   �� 5   
   -   5        $
 term��5      $
��Left=�6    $��210,204,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��162��6|   $��14(�6�   �� 5   
   -   5        $ termlbl��5      $
��Term��6!   $
��Left=�60   $��135,200,0,0q�6K   $	��Top=�6`   $��14(�6x   �� 5   
   -   5        $ email��5      $
��Left=�6!   $��210,169,0,0q�6<   $
 Wrap=�6Q   $	��Top=�6e   $	��162��6}   $��14(�6�   �� 5   
   -	   5        $ emailLbl��5      $��Email��6"   $
��Left=�62   $��132,161,0,0q�6M   $	��Top=�6b   $��14(�6z   �� 5   
   $:��4Student Database Connection with Rest API Properties��6   $
��Left=�6O   $��
130,10,0,0q�6j   $	��Top=�6~   $��15(�6�   �� 5   
   -
   5         ��Name$ 
AddStudent��5      $��Add Student��6%   $
��Left=�6;   $��
441,91,0,0q�6V   $	��Top=�6j   $��14(�6�   $��52��6�   6�   �� 5   
   -   5        $ showStudent��5      $��List All Student��6&   $
��Left=�6A   $��434,165,0,0q�6\   $	��Top=�6q   $��14(�6�   $��52��6�   6�   �� 5   
   -   5        $ search��5      $��Search��6!   $
��Left=�62   $��
695,15,0,0q�6M   $	��Top=�6a   $��14(�6y    J� RenderTransformOrigin$ 0.705,1.664&�6�   6�   �� 5   
   -   5        $ 	searchtxt��5      $
��Left=�6%   $��
596,16,0,0q�6@   $
 Wrap=�6T   $��id��6h   $	��Top=�6r   $��83��6�   $��14(�6�   �� 5   
   -   5        $ UpdateStudent��5      $��Update Student��6(   $
��Left=�6A   $��
569,92,0,0q�6\   $	��Top=�6p   $��14(�6�   $��52��6�   6�   �� 5   
   -   5        $ Delete��5      $��Delete Student��6!   $
��Left=�6:   $��569,165,0,0q�6U   $	��Top=�6j   $��14(�6�   $��52��6�   6�   �� 5   
   -   5        $ responselbl��5      $��Label��6%   $
��Left=�65   $��
454,45,0,0q�6P   $	��Top=�6d   $	��216��6|   ���	#FFFA0606$y�Hidden=�6�   5      5      