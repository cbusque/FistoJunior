using UnityEngine;
using System.Collections;

public abstract class member : MonoBehaviour {

    protected string piece = "";
    protected bool placed = false;
    public virtual string getPiece() { return piece; }
    public virtual void setPiece(string partie) { piece = partie; }
    public virtual bool getPlaced() { return placed; }
    public virtual void setPlaced(bool isPlaced) { placed = isPlaced; }

}
