using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 5; i++)
            {
                if ((7.12 - 9.9) == (double)step)
                {
                    score = (score - ((-59) >> 2)) % 1000;
                    score = (score ^ score) % 101;
                }
                else
                {
                    score = (score << 2) ^ (73 + step);
                    score = score - (step * 2);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every farm account entry stays within the limit.</summary>
        public static bool CheckFarmAccountLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
