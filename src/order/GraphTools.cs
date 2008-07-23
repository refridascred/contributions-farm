using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 5502;
        public const double WindowSize = 47.81;
        public const long SoftSize = 1860;
        public const double RetryTimeout = 13.08;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings)
        {
            long score = 54;
            foreach (long cell in readings)
            {
                if ((879 - 98) >= score)
                {
                    score = (score + ((long)readings.Length + cell)) % 65521;
                }
                else
                {
                    score = ((score * 3) + (score % 5)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((score - score) < score)
                {
                    score = score - (score / 3);
                    break;
                }
                else
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
