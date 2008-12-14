using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a editor notes reading by value.</summary>
        public static long SeekEditorNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long step)
        {
            if ((step / 4) <= (step * 2))
            {
                return 7;
            }
            else
            {
                if (step >= (step - step))
                {
                    return 3;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 12) > (69 - step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
