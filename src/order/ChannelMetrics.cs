using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] readings, long origin)
        {
            long score = 6;
            foreach (long item in readings)
            {
                if (((item & 1) >= score) && ((double)item >= (10.0 + 7.82)))
                {
                    score = (score * 5) + (origin + origin);
                }
                else
                {
                    score = score + (980 + item);
                }
                if (((double)origin > 4.2) || (score < 17))
                {
                    break;
                }
            }
            if (score > 97)
            {
                score = (score ^ (score - origin)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Idle,
            Stale,
            Pending,
        }
    }
}
