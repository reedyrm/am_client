   M S B A M L   `   `   `  ����  	AM_Client    AM_Client.Dashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  	Dashboard��5      .��5
      � $��0,60,0,0q�6   .+�5   
   o� $��31��6   $	��Top=�6   $��	0,-59,0,0q�63   $��2��6F   .@�5      m� $
��File��6   $��35��6%   .@�5      m� -   5         m�Name$ miChangePassword��5      $��Change Password��65   $��	0,0,-43,0q�6N   6a   �� 5      $
��Left=�6   $	��145��67   m� 5      -   5        $ miExit��5      $
��Exit��6+   $
��Left=�69   $	��145��6T   6`   5      m� 5      $��About��6   5      �� 5   
   -   5         ��Name$ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��
139,11,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5         ��Name$ txtZipCodeSearch��5      $
��Left=�6,   $��23��6G   $��	10,10,0,0q�6S    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgZipCodeSearchResults��5   F   $��	10,47,0,0q�6    J� RenderTransformOrigin$ 0.5,0.5&�6&      AutoGenerateColumns .     AlternatingRowBackground �#c2ccdb$
��Left=�5      $	��553��6.   $	��291��6:   $	��Top=�6G      
IsReadOnly . 	   CanUserAddRows	 .  
   SelectionMode$
 Single=�6�      SelectionUnit$
 Cell=�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
ZillowId+6N     5      $ ZipCode��6A   $ 80 6R    6%   �� *	ZipCode+6R     5      $ 
StreetName��6D   $	 200 6X    6%   �� *
StreetName+6X   5      �� 5   
   -   5        $ btnClear��5      $��Clear Results��6#   $
��Left=�6;   $��
233,11,0,0q�6V   $	��Top=�6j   $��75��6�   5      5       