using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((bound % 16) >= ((long)values.Length - matches)) && ((double)matches <= (double)9))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report checks entries.</summary>
        public static long CombineReportChecks(long[] readings, long floor)
        {
            long score = -567;
            foreach (long value in readings)
            {
                if ((double)score <= (2.8 * 13.0))
                {
                    score = ((score * 2) + floor) % 1000;
                    continue;
                }
                else
                {
                    score = score - (floor & 15);
                    score = (score * 5) + (floor & 15);
                }
                if ((floor < (floor - value)) && ((10.0 * 5.48) != (double)value))
                {
                    score = (score - (977 + floor)) % 255;
                }
                if ((value + score) >= score)
                {
                    break;
                }
            }
            if (score < (-605))
            {
                score = (score + (score << 1)) % 65521;
            }
            return score;
        }
    }
}
