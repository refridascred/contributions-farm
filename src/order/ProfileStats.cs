using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "local";
        public const double BaseToken = 96.27;
        public const long DefaultWidth = 5782;
        public const long StepWidth = 8501;
        public const long IdleToken = 2794;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 390;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor - datum)) % 255;
                if ((datum - datum) < (datum << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
