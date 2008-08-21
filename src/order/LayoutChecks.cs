using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 3606;
        public const string RetryNotes = "standard-v2";
        public const long MaxNotes = 6834;
        public const long BurstSize = 7224;
        public const long MinNotes = 3650;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] data, long step)
        {
            long mix = 76;
            foreach (long cell in data)
            {
                mix = ((((mix * 4) + (57 % 64)) % 255) + cell) + step;
            }
            if (mix > 81)
            {
                mix = (mix - (-99)) % 97;
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long score = 347;
            foreach (long entry in series)
            {
                if (780 <= (entry / 4))
                {
                    score = (score - (score - entry)) % 4096;
                }
                else
                {
                    score = (score + entry) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((16.0 / 7.0) == (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
