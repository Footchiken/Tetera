   M S B A M L   `   `   `  ����A  =Tetera, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TeteraTetera  5   	   R NSharpGL.WPF, Version=2.4.0.0, Culture=neutral, PublicKeyToken=27fc851303210b27>.clr-namespace:SharpGL.WPF;assembly=SharpGL.WPFSharpGL.WPF 5   	       Tetera.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tetera     5   	   >sgl.clr-namespace:SharpGL.WPF;assembly=SharpGL.WPF     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��0,88,0,0q�6+    � ColumnDefinitions 5   
   �� 5      $	��97* �6   �� 5      $	��35* �6    � RowDefinitions 5   
   �� 5      $	��95* �6   �� 5      $��7* �6   �� 5      $
��229* �6   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.345Q�6"   T� 5      5      .+�5   
   �� -   5         ��Name$ Modelo_luz_ambiental��5      $��Modelo de luz ambiental��61   $
��Left=�6S   $��	31,16,0,0q�6n   $	��Top=�6�   $ -1.017,-0.323&�6�   z�5      V� 5      .~�5       �� �� 5!      �� 5"      $ -0.312Q�6&   T� 5#      5$      5&      �� 5'   
   -   5        $! Modelo_luz_ambiental_global��5'      $$��Modelo de luz ambiental global��68   $
��Left=�6a   $��	31,36,0,0q�6|   $	��Top=�6�   6�   �� 5(   
   -   5        $ Posicion_de_luz��5(      $��Posición de luz��6,   $
��Left=�6F   $��	31,56,0,0q�6a   $	��Top=�6t   6�   �� 5)   
   -   5        $ Luz_ambiental��5)      $��Luz Ambiental��6*   $
��Left=�6B   $��	31,33,0,0q�6]   $	��Top=�6p   $��2��6�   �� 5*   
   -   5        $ Luz_especular��5*      $��Luz Especular��6*   $
��Left=�6B   $��	31,73,0,0q�6]   $	��Top=�6p   $��2��6�   �� 5+   
   -   5        $ 
Luz_difusa��5+      $��
Luz Difusa��6'   $
��Left=�6<   $��	31,53,0,0q�6W   $	��Top=�6j   $��2��6�     SharpGL.WPF.OpenGLControl  5-   
   -   5        $��289,-88,0,0q�5.   5   $ 0.521,0.503&�6J   $��3��6n   $��2��6   z�5/      V� 50      .~�51      �� �� 52      �� 53      $ 0.379Q�6&   T� 54      55      57      58      59      