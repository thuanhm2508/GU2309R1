using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    //Xác định giá trị từng ô cờ [null,X,O]
    public enum FIELD { FLD_EMPTY = ' ', FLD_X = 'X', FLD_O = 'O' }
    public class Cell
    {
        //Khởi tạo mặc định ô cờ là null
        FIELD fieldState = FIELD.FLD_EMPTY;

        public Cell(FIELD fieldState = FIELD.FLD_EMPTY)
        {
            this.FieldState = fieldState;
        }
        //getter / setter
        public FIELD FieldState { get => fieldState; set => fieldState = value; }
        //Kiểm tra ô cờ có rỗng không.
        public bool isEmpty()
        {
            return fieldState == FIELD.FLD_EMPTY;
        }
        //Điền dấu người chơi vào ô
        public void markField(char c)
        {
            if (c == 'X')       fieldState = FIELD.FLD_X; 
            else if (c == 'O')  fieldState = FIELD.FLD_O;
            else                fieldState = FIELD.FLD_EMPTY;
            
        }
    }
}
