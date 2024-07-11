using Eflatun.SceneReference;
using System;

namespace Mert.SceneManagement
{
    [Serializable]
    public class SceneData
    {
        public SceneReference Reference;
        public string Name => Reference.Name;
        public SceneType SceneType;
    }
}