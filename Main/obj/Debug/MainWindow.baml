   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	       Main.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��710��6)    � WindowStartupLocation$ CenterScreen=�65    � 
ResizeMode$ CanMinimize=�6Z   .��5	      � .+�5
   
   �� .@�5      �� $��Compare Image��6   .��5      � ���	#ffe5e5e5.+�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��目標圖檔��6#   $
��Left=�61   $	��Top=�6L   $��	10,10,0,0q�6d   $��65��6w   $	��645��6�   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��TargetImagePathTextBox��5   *   $
��Left=�6I   $��23��6d   $��	10,10,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��536��6�    �� 
IsReadOnly . 6�   �� 5   "   -   5        $��選取檔案��5   )   $
��Left=�68   $��5,10,0,0q�6S   $	��Top=�6e   $��75��6}    J� RenderTransformOrigin$ 1.247,-0.265&�6�   6�   5      5      �� 5      $��比較圖檔��6#   $
��Left=�61   $	��Top=�6L   $��	10,10,0,0q�6d   $��65��6w   $	��645��6�   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� -   5        $��CompareImagePathTextBox��5   *   $
��Left=�6J   $��23��6e   $��	10,10,0,0q�6q   $
 Wrap=�6�   $	��Top=�6�   $	��536��6�    . 6�   �� 5   "   -   5        $��選取檔案��5   )   $
��Left=�68   $��5,10,0,0q�6S   $	��Top=�6e   $��75��6}   $ 1.247,-0.265&�6�   6�   5      5      �� 5      $��圖片預覽��6#   $
��Left=�61   $	��Top=�6L   $��	10,10,0,0q�6d   $	��200��6w   $	��645��6�   .��5      �� $ 
Horizontal=�6)   .+�5   "   �� $ Vertical=�6-   $��	10,10,0,0q�6D   $��Center=�6W   .+�5   &   �� -   5        $��TargetImage��5   ,   $	��100��6?   $	��100��6K   �� 5   &   $��目標圖檔��6,   5   #   �� 5    "   $ Vertical=�6-   $��	10,10,0,0q�6D   $��Center=�6W   .+�5!   &   �� -   5        $��ComareImage��5!   ,   $	��100��6?   $	��100��6K   �� 5"   &   $��比較圖檔��6,   5#   #   5$      5%      �� 5&      -   5        $��FindShapeButton��5&   !   $��確定��68   $
��Left=�6E   $��
538,10,0,0q�6`   $	��Top=�6t   $	��115��6�   $��36��6�   5'      5(      5)      �� 5*      $��	Watermark��6   .��5+      � ���	#ffe5e5e5.+�5,      �� $ Vertical=�6!   .+�5-      �� $��目標圖檔��6#   $
��Left=�61   $	��Top=�6L   $��	10,10,0,0q�6d   $��65��6w   $	��645��6�   .��5.      �� $ 
Horizontal=�6)   .+�5/   "   �� -   5        $&�� WartermarkTargetImagePathTextBox��5/   *   $
��Left=�6S   $��23��6n   $��	10,10,0,0q�6z   $
 Wrap=�6�   $	��Top=�6�   $	��536��6�    . 6�   �� 50   "   -	   5        $��選取檔案��50   )   $
��Left=�68   $��5,10,0,0q�6S   $	��Top=�6e   $��75��6}   $ 1.247,-0.265&�6�   6�   51      52      �� 53      $��圖片預覽��6#   $
��Left=�61   $	��Top=�6L   $��	10,10,0,0q�6d   $	��200��6w   $	��645��6�   .��54      �� $ 
Horizontal=�6)   .+�55   "   �� $ Vertical=�6-   $��	10,10,0,0q�6D   $��Center=�6W   .+�56   &   �� -
   5        $��WartermarkTargetImage��56   ,   $	��100��6I   $	��100��6U   �� 57   &   $��目標圖檔��6,   58   #   �� 59   "   $ Vertical=�6-   $��	10,10,0,0q�6D   $��Center=�6W   .+�5:   &   �� -   5        $��WartermarkPreviewImage��5:   ,   $	��100��6J   $	��100��6V   �� 5;   &   $��套印預覽��6,   5<   #   5=      5>      �� 5?      -   5        $��WatermarkButton��5?   !   $��確定��68   $
��Left=�6E   $��
538,10,0,0q�6`   $	��Top=�6t   $	��115��6�   $��36��5@   D   5A      5B      5C      5D      5E      5F      