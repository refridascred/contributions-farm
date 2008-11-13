using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "legacy-v2";
        public const long MinRatio = 1321;
        public const long MinLevel = 9984;

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Digest a series of channel batch entries.</summary>
        public static long DigestChannelBatch(long[] values)
        {
            long acc = 392;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (0 << 3)) % 97;
                acc = ((acc << 3) ^ datum) % 101;
            }
            if (acc < (-5))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
