Visual_Sort_Array
=================
Программа для визуального отображения различных видов сортировки массива (C#)

For visualization was created class Indicator heir from the System.Windows.Forms.Panel, which is configured to display the visualization of the data array, depending on the entered parameters.
PrepareScale Function responsible for the preparation of the sizes of the columns in the display, it is setting the scaling factor of the array elements based on the height of the indicator in pixels. The scale factor is determined and the maximum element of the array, i.e. Max. cut element of the array is guaranteed to fit in the indicator area. Also determines the thickness of the pen for a column based on the size of the array, i.e. you need to put all the elements of the array horizontally in the region of the indicator.
ShowScale - Function display array in columns
Creating and adding object Indicator on the form elements is in the form designer
