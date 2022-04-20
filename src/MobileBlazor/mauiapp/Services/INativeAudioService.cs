﻿namespace NetPodsMauiBlazor.Services;

internal interface INativeAudioService
{
    Task InitializeAsync(string audioURI);

    Task PlayAsync(double position = 0);

    Task PauseAsync();

    Task SetMuted(bool value);

    Task SetVolume(int value);

    Task SetCurrentTime(double value);

    bool IsPlaying { get; }

    double CurrentPosition { get; }
}
