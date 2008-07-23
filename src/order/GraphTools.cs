using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long anchor = 41;
            foreach (long entry in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    long slot = anchor;
                    anchor = ((anchor ^ (slot - entry)) % 4096) ^ (long)i;
                }
                anchor = (anchor ^ (anchor >> 5)) % 1000;
            }
            return anchor;
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

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data, long limit)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark + (limit ^ limit)) - sample;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
