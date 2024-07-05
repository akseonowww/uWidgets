﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace uWidgets.Controls;

public partial class Setting : UserControl
{
    public static readonly StyledProperty<StreamGeometry> IconProperty = 
        AvaloniaProperty.Register<Setting, StreamGeometry>(nameof(Icon));

    public static readonly StyledProperty<string> TitleProperty = 
        AvaloniaProperty.Register<Setting, string>(nameof(Title));

    public static readonly StyledProperty<string> SubtitleProperty = 
        AvaloniaProperty.Register<Setting, string>(nameof(Subtitle));

    public StreamGeometry Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public string Title
    {
        get => GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Subtitle
    {
        get => GetValue(SubtitleProperty);
        set => SetValue(SubtitleProperty, value);
    }

    public Setting()
    {
        InitializeComponent();
    }
}