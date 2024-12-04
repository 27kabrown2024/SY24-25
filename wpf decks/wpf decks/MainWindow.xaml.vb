Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        purdue.Visibility = Visibility.Visible
        georgia.Visibility = Visibility.Hidden
        ohio.Visibility = Visibility.Hidden
        founder.Content = "The founder is John Purdue"
        year.Content = "It was founded on May 6, 1869"
        fame.Content = "is the most famous player Rick Mount"
        loc.Content = "It is located in West Lafayette, Indiana"
    End Sub

    Private Sub buttongeorgia_Click(sender As Object, e As RoutedEventArgs) Handles buttongeorgia.Click
        purdue.Visibility = Visibility.Hidden
        georgia.Visibility = Visibility.Visible
        ohio.Visibility = Visibility.Hidden
        year.Content = "It was founded on January 25, 1892"
        loc.Content = "It is located in Athens, Georgia"
        founder.Content = "The founder is Frank Seiler"
        fame.Content = "is the most famous player Fran Tarkenton"
    End Sub

    Private Sub buttonohio_Click(sender As Object, e As RoutedEventArgs) Handles buttonohio.Click
        purdue.Visibility = Visibility.Hidden
        georgia.Visibility = Visibility.Hidden
        ohio.Visibility = Visibility.Visible
        year.Content = "It was founded on 1870"
        loc.Content = "It is located in Columbus, Ohio"
        founder.Content = "The founder is Rutherford B. Hayes"
        fame.Content = "is the most famous player Archie Griffin"
    End Sub
End Class
