using System;

namespace SSS.Core
{
    [Serializable]
    public enum MonitorType : byte
    {
        CPU,
        RAM,
        GPU,
        HD,
        Network,
        Time,
        Window,
        Claude,
        Codex
    }

    [Serializable]
    public enum MetricKey : byte
    {
        CPUClock     = 0,
        CPUTemp      = 1,
        CPUVoltage   = 2,
        CPUFan       = 3,
        CPULoad      = 4,
        CPUCoreLoad  = 5,
        CPUPower     = 6,

        RAMClock     = 10,
        RAMVoltage   = 11,
        RAMLoad      = 12,
        RAMUsed      = 13,
        RAMFree      = 14,

        GPUCoreClock = 20,
        GPUVRAMClock = 21,
        GPUCoreLoad  = 22,
        GPUVRAMLoad  = 23,
        GPUVoltage   = 24,
        GPUTemp      = 25,
        GPUFan       = 26,
        GPUPower     = 27,
        GPUVRAMUsed  = 28,
        GPUVRAMFree  = 29,

        NetworkIP    = 30,
        NetworkExtIP = 31,
        NetworkIn    = 32,
        NetworkOut   = 33,

        DriveLoadBar = 40,
        DriveLoad    = 41,
        DriveUsed    = 42,
        DriveFree    = 43,
        DriveRead    = 44,
        DriveWrite   = 45,

        Time         = 50,
        Date         = 51,

        WindowTitle  = 60,

        Claude5h     = 70,
        Claude1w     = 71,
        Codex5h      = 72,
        Codex1w      = 73,
        CodexCredits = 74
    }

    public enum ResetTimeDisplay : byte
    {
        Countdown,
        Absolute
    }

    public enum AutoRefreshInterval : byte
    {
        Manual,
        OneMin,
        FiveMin,
        TenMin
    }

    public enum TextAlign : byte
    {
        Left,
        Right
    }

    public enum SectionHeaderStyle : byte
    {
        Default,
        Small,
        None,
        NoIcon
    }

    public enum DataType : byte
    {
        Dynamic,
        Bit,
        Kilobit,
        Megabit,
        Gigabit,
        Byte,
        Kilobyte,
        Megabyte,
        Gigabyte,
        bps,
        kbps,
        Mbps,
        Gbps,
        Bps,
        kBps,
        MBps,
        GBps,
        MHz,
        GHz,
        Voltage,
        Percent,
        RPM,
        Celsius,
        Fahrenheit,
        IP,
        Watt
    }
}
