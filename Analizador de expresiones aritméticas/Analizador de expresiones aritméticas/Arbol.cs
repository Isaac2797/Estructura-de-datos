using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_de_expresiones_aritméticas
{
    class Arbol
    {
        
        EstructuraStack stack = new EstructuraStack();
        private Nodo raiz, temp1, temp2, PostTree;
        public void Agregar(Nodo nuevo)
        {
            Nodo temp = null;

            if (raiz == null)
            {
                raiz = nuevo;
            }
            else if (raiz.value == null)
            {
                raiz = nuevo;
            }
            else if (nuevo.value == "*" || nuevo.value == "/" || nuevo.value == "-" || nuevo.value == "+")
            {
                if (nuevo.value == "+" || nuevo.value == "-")
                {
                    nuevo.Left = raiz;
                    raiz = nuevo;
                }
                else if (nuevo.value == "*" || nuevo.value == "/")
                {
                    if(raiz.value == "+" || raiz.value == "-")
                    {
                        if (raiz.Left == null)
                            raiz.Left = nuevo;
                        else if(raiz.Right != null)
                        {
                            temp = raiz.Right;
                            raiz.Right = nuevo;
                            nuevo.Left = temp;
                            //raiz.Right = temp;
                            //temp.Left = nuevo;
                        }
                        else
                            raiz.Right = nuevo;
                    }
                }
            }
            else
            {
                stack.Put(nuevo);
            }
            temp1 = temp2 = raiz;
            
        }
        public void acomodar()
        {
            RightSide(raiz);
        }
        public Nodo RightSide(Nodo Raiz)
        {
            while (stack.end() != null)
            {
                if (temp1.Right == null)
                {
                    temp1.Right = stack.Pop();
                    RightSide(temp1);
                }
                else if (temp1.Left == null)
                {
                    temp1.Left = stack.Pop();
                    RightSide(temp1);
                }
                else if (temp1.Right.value == "*" || temp1.Right.value == "/" || temp1.Right.value == "-" || temp1.Right.value == "+")
                {
                    temp1 = temp1.Right;
                    RightSide(temp1);
                }
                else if (temp1.Left.value == "*" || temp1.Left.value == "/" || temp1.Left.value == "-" || temp1.Left.value == "+")
                {
                    temp1 = temp1.Left;
                    RightSide(temp1);
                }
                else
                {
                    temp1 = temp2.Left;
                    temp2 = temp2.Left;
                    RightSide(temp1);
                }
            }
            return raiz;
        }
        string output;
        public string Posty()
        {
            output = "";
            PostTree = raiz;
            PostOrder(PostTree);
            return output;
        }

        public void PostOrder(Nodo raiz)
        {
            if (PostTree.value == null)
                output = output;
            else
            {
                if (raiz.Left != null)
                {
                    if (raiz.Left.value == "*" || raiz.Left.value == "/" || raiz.Left.value == "-" || raiz.Left.value == "+")
                    {
                        raiz = raiz.Left;
                        PostOrder(raiz);

                    }
                    else
                    {
                        output += raiz.Left.value;
                        raiz.Left = null;
                        PostOrder(PostTree);
                    }
                }
                else if (raiz.Right != null)
                {
                    if (raiz.Right.value == "*" || raiz.Right.value == "/" || raiz.Right.value == "-" || raiz.Right.value == "+")
                    {
                        raiz = raiz.Right;
                        PostOrder(raiz);
                    }
                    else
                    {
                        output += raiz.Right.value;
                        raiz.Right = null;
                        PostOrder(PostTree);
                    }
                }
                else if (raiz.Right == null && raiz.Left == null)
                {
                    output += raiz.value;
                    raiz.value = null;
                    raiz = null;
                    if (PostTree != null)
                    {
                        PostOrder(PostTree);
                    }
                }
            }
        }
        public string Presty()
        {
            output = "";
            PostTree = raiz;
            PreOrder(PostTree);
            return output;
        }
        public void PreOrder(Nodo raiz)
        {
            if (PostTree.value == null)
                output = output;
            else
            {
                if (raiz.Right != null)
                {
                    if (raiz.Right.value == "*" || raiz.Right.value == "/" || raiz.Right.value == "-" || raiz.Right.value == "+")
                    {
                        raiz = raiz.Right;
                        PreOrder(raiz);

                    }
                    else
                    {
                        output = raiz.Right.value + output;
                        raiz.Right = null;
                        PreOrder(PostTree);
                    }
                }
                else if (raiz.Left != null)
                {
                    if (raiz.Left.value == "*" || raiz.Left.value == "/" || raiz.Left.value == "-" || raiz.Left.value == "+")
                    {
                        raiz = raiz.Left;
                        PreOrder(raiz);
                    }
                    else
                    {
                        output = raiz.Left.value + output;
                        raiz.Left = null;
                        PreOrder(PostTree);
                    }
                }
                else if (raiz.Right == null && raiz.Left == null)
                {
                    output = raiz.value + output;
                    raiz.value = null;
                    raiz = null;
                    if (PostTree != null)
                    {
                        PreOrder(PostTree);
                    }
                }
            }
        }
    }
}
