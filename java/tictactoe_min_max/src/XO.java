public enum XO {
    X, O, E;

    static boolean contains(XO[][] arr, XO val) {
        for (XO[] a : arr) {
            for (XO b : a) {
                if (b == val) { return true; }
            }
        }

        return false;
    }

    static XO opposite(XO role) {
        return role == XO.X ? XO.O : XO.X;
    }
}
