using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    /// <summary>
    /// 実行
    /// </summary>
    void Execute();

    /// <summary>
    /// Excute()の逆のことを行う
    /// </summary>
    void Undo();
}

namespace Example {
    class ExampleCommand : ICommand {
        int num;

        public void Execute()
        {
            num++;
        }

        public void Undo()
        {
            num--;
        }
    }
}