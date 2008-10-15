using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long result = 58;
            foreach (long reading in levels)
            {
                result = ((result << 2) ^ (result << 2)) % 4096;
                if ((87 ^ (-30)) >= result)
                {
                    result = ((result * 4) + (reading << 2)) % 255;
                }
                if ((reading - reading) < reading)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool ValidateQueueCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long target)
        {
            long score = 19;
            foreach (long cell in readings)
            {
                score = ((score * 4) + cell) % 65521;
                score = (score + (cell & 127)) % 65521;
            }
            if (score > (-22))
            {
                score = score ^ (target & 1);
            }
            return score % 65521;
        }
    }
}
